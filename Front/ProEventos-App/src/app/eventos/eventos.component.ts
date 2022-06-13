import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos : any = [];
  public eventosFiltrados : any = [];
  larguraImagem: number = 150;
  margemImagem: number = 2;
  mostrarImagem: boolean = true;
  private _filtrolista: string = '';
  // pode ser assim também
  //imagemLargura = 50;

  constructor(private http: HttpClient) { }

  public get filtrolista() : string {
    return this._filtrolista;
  }
  public set filtrolista(value : string) {
    this._filtrolista = value;
    this.eventosFiltrados = this._filtrolista ? this.filtrarEventos(this._filtrolista) : this.eventos
  }

  filtrarEventos(filtrarPor : string) : any
  {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (evento: { tema: string; local : string }) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      evento.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )

  }

  ngOnInit(): void {
    this.getEventos();
  }

  public exibirImagens()
  {
    this.mostrarImagem = !this.mostrarImagem;
  }

  public getEventos() : void{
      this.http.get('https://localhost:5001/api/Eventos').subscribe(
        response => {
            this.eventos = response;
            this.eventosFiltrados = this.eventos;
        },
        errors => console.log(errors)
      );


  }

}
