import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
List:any=[]=[];
add(item:string)
{
  
  this.List.push({id:this.List.length,value:item});
  console.log(this.List);
}
delete(id:number){
  //this.List= this.List.filter(tt => tt.id !==id);
  //this.List = this.List.filter(item->item.id!==id)
  if(this.List.length==1)
  {
    this.List=[]=[];
  }
  else{
    this.List.splice(this.List.indexOf(id),id);
  }
  

}
}
