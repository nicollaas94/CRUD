import { Component, OnInit } from '@angular/core';
import { CrudService } from '../../services/crud.service';

@Component({
  selector: 'app-criar',
  templateUrl: './criar.component.html',
  styleUrls: ['./criar.component.scss']
})
export class CriarComponent implements OnInit {
  candidato: DTO.Candidato;
  banco: DTO.Banco;
  conhecimento: DTO.Conhecimento;
  step: number;

  constructor(private _service: CrudService) {  
    this.step = 1;
    this.candidato =  <DTO.Candidato> new Object();
    this.banco = <DTO.Banco> new Object();
    this.conhecimento = <DTO.Conhecimento> new Object();
  }

  ngOnInit() {
  }

  cadastrar(){
    this.candidato.Banco = this.banco;
    this.candidato.Conhecimento = this.conhecimento;
    this._service.cadastraCandidatos(this.candidato).subscribe(
      data => {

      }
    );
  }

}
