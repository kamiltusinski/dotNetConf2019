import FetchData from './FetchData';
import Home from './Home';
import React from 'react';
import { Container } from 'semantic-ui-react';
import { NavMenu } from './NavMenu';
import { Route } from 'react-router';

const App: React.FC = () => {
  return (
    <div>
      <NavMenu />
      <Container style={{ paddingTop: 55 }}>
        <Route exact path="/" component={Home} />
        <Route path="/fetch-data" component={FetchData} />
      </Container>
    </div>
  );
};

export default App;
