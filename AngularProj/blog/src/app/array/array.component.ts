import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-array',
  templateUrl: './array.component.html',
  styleUrls: ['./array.component.css']
})
export class ArrayComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  title="hello this is my title";
  users=[
    {name:"saabir1",phone:1111 , accounts:["Axis Bank","SBI","BOB"]},
    {name:"saabir2",phone:2222, accounts:["Axis Bank","SBI","BOB"]},
    {name:"saabir3",phone:3333, accounts:["Axis Bank","SBI","BOB"]}
  ]

}
