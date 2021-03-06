import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { HomeComponent } from './components/home/home.component';
import { CategoryItemsListComponent } from './components/category-items-list/category-items-list.component';
import { ItemFormComponent } from './components/item-form/item-form.component';

import { CategoriesService } from './services/categories.service';
import { ItemsService } from './services/items.service';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CategoryItemsListComponent,
    ItemFormComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'category-items-list', component: CategoryItemsListComponent },
    ])
  ],
  providers: [
    CategoriesService,
    ItemsService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
