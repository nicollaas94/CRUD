import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CrudService } from '../../services/crud.service';

@Component({
  selector: 'app-listar',
  templateUrl: './listar.component.html',
  styleUrls: ['./listar.component.scss']
})
export class ListarComponent implements OnInit {
  urlpath: string;
  candidatos: Array<DTO.Candidato>
  IsBusy: boolean;

  constructor(private _service: CrudService, private route: ActivatedRoute) {
    route.url.subscribe( url => {
      if(url.length > 0){
        this.urlpath = url[0].path;
      }
      else{
        this.urlpath = "listar";
      }      
    });
    this.listarCandidatos();
  }

  ngOnInit() {
  }

  listarCandidatos() {
    let self = this;
    this.IsBusy = true;
    this._service.carregaCandidatos().subscribe(
      data => {
        self.candidatos = data;
        this.IsBusy = false;
      },
      error => {
        //this.alertService.error(error.json().TESTE);
        this.IsBusy = false;
      }
    );
  }

  excluirUsuario(idCandidato: number){
    this._service.excluirCandidato(idCandidato).subscribe(
      data => {
        this.listarCandidatos();
      }
    )
  }

}
