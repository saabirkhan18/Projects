import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit {

  constructor() { }
@ Input() item=0;
value1=0
  ngOnInit(): void {
    this.value1=this.item
  }
  update()
  {
    this.value1++
  }
}
