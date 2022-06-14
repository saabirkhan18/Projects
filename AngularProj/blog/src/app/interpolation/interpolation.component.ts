import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-interpolation',
  templateUrl: './interpolation.component.html',
  styleUrls: ['./interpolation.component.css']
})
export class InterpolationComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  title = 'Hello saabir';
  data="step by step";
  GetMyData()
  {
    return "hello this is function data";
  }
 a=100;
}
