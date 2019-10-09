import { Component, OnInit } from '@angular/core';
import {Department} from './dept';
import {DeptsService} from './depts.service';
import {HttpClient} from '@angular/common/http';


@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  deptlist:Department[];
  dep:Department;
  ifupdate=false;

  constructor(private depts:DeptsService) { 
    this.deptlist = this.depts.getlist();
  }

  ngOnInit() {
  }

  editdata(index:number){
    this.ifupdate=true;
    console.log(index)
    this.dep=this.depts.deptlist[index];
    this.depts.update(this.dep,index)
  }

  deletedata(index:number){
    this.depts.delete(index);
  }
  done(){
    this.ifupdate=false
  }

}
