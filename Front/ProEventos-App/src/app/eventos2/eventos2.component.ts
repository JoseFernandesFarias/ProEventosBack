import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos2',
  templateUrl: './eventos2.component.html',
  styleUrls: ['./eventos2.component.scss']
})
export class Eventos2Component implements OnInit {

  public eventos: any = [];
  public larguraImagem: number = 150;
  public margemImagem: number = 2;
  public mostrarImagem: boolean = true;

  constructor(private http:HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  exibirImagens()
  {
      this.mostrarImagem = !this.mostrarImagem;
  }

  public getEventos(): void
  {
    this.http.get('https://localhost:5001/api/Eventos').subscribe(
      response => this.eventos = response,
      errors => console.log(errors)
    );
  }

}
