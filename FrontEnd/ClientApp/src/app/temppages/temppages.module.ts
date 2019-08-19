import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { GmSharedModule } from '../gmshared/gmshared.module'
import { ServerdemoComponent } from './serverdemo.component';
import { HomedemoComponent } from './homedemo.component';
import { OtherfeaturesComponent } from './otherfeatures.component';
import { SearchComponent } from './search.component';
import { RegisterGovComponent } from './registergov.component';

@NgModule({
  imports: [
        CommonModule,
        RouterModule,
        GmSharedModule
  ],
    declarations: [
        ServerdemoComponent,
        HomedemoComponent,
        OtherfeaturesComponent,
        SearchComponent,
        RegisterGovComponent
    ],
    exports: [
        ServerdemoComponent,
        HomedemoComponent,
        OtherfeaturesComponent,
        SearchComponent,
        RegisterGovComponent
    ]
})
export class TemppagesModule { }