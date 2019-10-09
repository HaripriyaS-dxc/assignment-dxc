import { Injectable } from '@angular/core';
import {Department} from './dept';

@Injectable({
  providedIn: 'root'
})
export class DeptsService {

  constructor() { }

deptlist: Department[] = [{DepartmentID:1,Name:'Engineering',GroupName:'Research and Development',ModifiedDate:new Date('2002-01-06')},
{DepartmentID:2,Name:'Tool Design',GroupName:'Research and Development',ModifiedDate:new Date('2003-08-16')},
{DepartmentID:3,Name:'Sales',GroupName:'Sales and Marketing',ModifiedDate:new Date('2012-11-17')},
{DepartmentID:4,Name:'Marketing',GroupName:'Sales and Marketing',ModifiedDate:new Date('2011-05-09')},
{DepartmentID:5,Name:'Purchasing',GroupName:'Inventory and Management',ModifiedDate:new Date('2009-10-26')}];


getlist(){
  return this.deptlist;
}

save(department:Department){
  this.deptlist.push(department);
}

update(department:Department,index:number){
  this.deptlist[index]=department;
}

delete(index:number){
  this.deptlist.splice(index,1);
}

}
