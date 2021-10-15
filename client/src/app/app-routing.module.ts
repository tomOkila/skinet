import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from 'src/core/not-found/not-found.component';
import { ServerErrorComponent } from 'src/core/server-error/server-error.component';
import { TestErrorComponent } from 'src/core/test-error/test-error.component';
import { ProductDetailsComponent } from 'src/shop/product-details/product-details.component';
import { ShopComponent } from 'src/shop/shop.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  {path: '',component:HomeComponent},
  {path: 'test-error',component:TestErrorComponent},
  {path: 'server-error',component:ServerErrorComponent},
  {path: 'not-found',component:NotFoundComponent},
  {path: 'shop', loadChildren: () => import('../shop/shop.module').then(mod => mod.ShopModule)},
  {path: '**',redirectTo:'',pathMatch:'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
