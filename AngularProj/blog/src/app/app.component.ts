import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Hello saabir';
  data="step by step";
  GetMyData()
  {
    return "hello this is function data";
  }
 a=100;
}
