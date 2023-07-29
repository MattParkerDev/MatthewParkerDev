import type { Component } from 'solid-js';
import { Link, useRoutes, useLocation } from '@solidjs/router';

import { routes } from './routes';
import NavBar from './components/NavBar';
import SiteWrapper from './components/SiteWrapper';

const App: Component = () => {
  const location = useLocation();
  const Route = useRoutes(routes);

  return (
    <>
    <SiteWrapper>

      <NavBar />
      <main class="h-full box-content">
        <Route />
      </main>
    </SiteWrapper>
    </>
  );
};

export default App;
