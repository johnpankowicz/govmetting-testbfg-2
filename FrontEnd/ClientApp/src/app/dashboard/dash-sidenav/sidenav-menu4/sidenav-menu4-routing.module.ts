import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {InfoCityComponent} from './info-city/info-city.component';
import {InfoCountyComponent} from './info-county/info-county.component';
import {InfoStateComponent} from './info-state/info-state.component';
import {InfoFederalComponent} from './info-federal/info-federal.component';

const routes: Routes = [
  {path: '', component: InfoFederalComponent, pathMatch: 'full'},
  {path: 'info-federal/:id/:location', component: InfoFederalComponent, outlet:"sidenav"},
  {path: 'info-city', component: InfoCityComponent, outlet:"sidenav"},
  {path: 'info-county', component: InfoCountyComponent, outlet:"sidenav"},
  {path: 'info-state', component: InfoStateComponent, outlet:"sidenav"}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: []
})
export class SidenavMenu4RoutingModule {
}


/*
  When an item is selected, menu-list-item.component.ts calls:
    onItemSelected(item: NavItem)
  which calls:.
    this.router.navigate([{outlets: {sidenav: item.route}}]);

  This will load the content of the selected component into:
      <router-outlet name="sidenav"></router-outlet>
  in sidenav-menu4.component.html.

*/
