import { Component, OnInit } from '@angular/core';
import {DeptsService} from './depts.service';
import {Department} from './dept';
import {NgForm} from '@angular/forms'
import {Router} from '@angular/router';


@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.scss']
})
export class CreateComponent implements OnInit {
dept=new Department();

  constructor( private deptser:DeptsService,private route:Router) { }

  ngOnInit() {}

savedata():void{
  this.deptser.save(this.dept);
  this.route.navigate(['list']);

  }

}
