import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { DemoComponent } from './demo/demo.component';
import { CounterComponent } from './counter/counter.component';
import { ArrayComponent } from './array/array.component';
import { InterpolationComponent } from './interpolation/interpolation.component';
import { StylebindingComponent } from './stylebinding/stylebinding.component';
import { HeaderComponent } from './header/header.component';
import {FormsModule} from '@angular/forms';
import { ListComponent } from './list/list.component';
import { ChildComponent } from './child/child.component'

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    DemoComponent,
    CounterComponent,
    ArrayComponent,
    InterpolationComponent,
    StylebindingComponent,
    HeaderComponent,
    ListComponent,
    ChildComponent
    
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
