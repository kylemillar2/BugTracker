import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-bug-box',
  templateUrl: './bug-box.component.html',
  styleUrls: ['./bug-box.component.css']
})
export class BugBoxComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  title = "temp title"
  description = `Lorem ipsum dolor sit amet, consectetur 
    adipiscing elit. Etiam nec purus quis nibh lobortis 
    posuere a a lacus. Aliquam hendrerit sapien a elit 
    malesuada ultrices.`

}
