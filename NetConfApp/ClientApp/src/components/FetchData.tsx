import axios from 'axios';
import React, { useEffect, useRef, useState } from 'react';
import { Progress, Segment } from 'semantic-ui-react';

function useInterval(callback: any, delay: number) {
  const savedCallback = useRef<any>();

  useEffect(() => {
    savedCallback.current = callback;
  });

  useEffect(() => {
    const id = setInterval(() => savedCallback.current(), delay);
    return () => clearInterval(id);
  }, [delay]);
}

const FetchData: React.FC = () => {
  const [data, setData] = useState<any>({});
  const [count, setCount] = useState(100);

  const fetchData = async () => {
    const result = await axios('jokes/programming/random');
    setData(result.data);
  };

  useEffect(() => {
    fetchData();
  }, []);

  useInterval(() => {
    if (count < 0) {
      fetchData();
      setCount(100);
    } else {
      setCount(count => count - 1);
    }
  }, 100);

  return (
    <Segment>
      <Progress percent={count} attached="bottom" />
      <div>
        <h2>{data ? data.setup : ''}</h2>
        <h2>{data ? data.punchline : ''}</h2>
      </div>
    </Segment>
  );
};

export default FetchData;
