import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-editar',
  templateUrl: './editar.component.html',
  styleUrls: ['./editar.component.scss']
})
export class EditarComponent implements OnInit {
  urlpath: string;

  constructor( private route: ActivatedRoute){ 
      route.url.subscribe( url => {this.urlpath = url[0].path;});
  }

  ngOnInit() {
    this.route.params.subscribe(params => {           
        <number>params['id'];
    });
  }

}
