import { Component } from '@angular/core';
import * as Highcharts from "highcharts";
import * as signalR from "@microsoft/signalr";
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  Highcharts: typeof Highcharts = Highcharts;
  chartOptions: Highcharts.Options = {
    //Grafik Title
    title: {
      text: "Başlık"
    },
    subtitle: {
      text: "Alt Başlık"
    },
    yAxis: {
      title: {
        text: "Y Ekseni"
      }
    },
    xAxis: {
      accessibility: {
        rangeDescription: "2019 - 2020"
      }
    },
    legend: {
      layout: "vertical",
      align: "right",
      verticalAlign: "middle"
    },
    series: [
      {
        name: "X",
        data: [1000, 2000, 3000],
        type: "column"
      },
      {
        name: "Y",
        data: [5000, 6000, 7000],
        type: "column"
      },
      {
        name: "Z",
        data: [1000, 10000, 3000],
        type: "column"
      },
    ],
    plotOptions: {
      series: {
        label: {
          connectorAllowed: true
        },
        pointStart: 100
      }
    }
  }
}
