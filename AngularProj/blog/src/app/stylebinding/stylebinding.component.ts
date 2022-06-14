import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-stylebinding',
  templateUrl: './stylebinding.component.html',
  styleUrls: ['./stylebinding.component.css']
})
export class StylebindingComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  color="green";
bgColor="yellow";
  changecolor(){
    this.color="red";
    this.bgColor="gray";
  }
}
