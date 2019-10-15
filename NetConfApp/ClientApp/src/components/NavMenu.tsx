import React from 'react';
import { Container, Menu } from 'semantic-ui-react';
import { Link } from 'react-router-dom';

export const NavMenu: React.FC = () => {
  return (
    <Menu fixed="top" inverted>
      <Container>
        <Menu.Item as={Link} to="/" header>
          NetConfApp 2019
        </Menu.Item>
        <Menu.Item as={Link} to="/fetch-data">
          Show me joke
        </Menu.Item>
      </Container>
    </Menu>
  );
};
