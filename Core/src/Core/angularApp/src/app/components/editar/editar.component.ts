import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CrudService } from '../../services/crud.service';

@Component({
  selector: 'app-editar',
  templateUrl: './editar.component.html',
  styleUrls: ['./editar.component.scss']
})
export class EditarComponent implements OnInit {
  urlpath: string;
  candidatoId: number;
  candidato: DTO.Candidato;
  step: number;

  constructor(private _service: CrudService, private route: ActivatedRoute) {
    this.step = 1;
    this.candidato = <DTO.Candidato>new Object();
    route.url.subscribe(url => { this.urlpath = url[0].path; });
  }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.candidatoId = <number>params['id'];
      this.pegaCandidatoEspecifico();

    });
  }

  pegaCandidatoEspecifico() {
    this._service.carregaCandidatoEspecifico(this.candidatoId).subscribe(
      data => {
        this.candidato = data;
      }
    );
  }

}
