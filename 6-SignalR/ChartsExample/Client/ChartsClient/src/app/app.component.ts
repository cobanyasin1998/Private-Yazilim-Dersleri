import { Component } from '@angular/core';
import * as Highcharts from "highcharts";
import * as signalR from "@microsoft/signalr";
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  connection: signalR.HubConnection;
  constructor() {
    this.connection = new signalR.HubConnectionBuilder().withUrl("https://localhost:5001/satishub").build();
    this.connection.start();

    this.connection.on("receiveMessage", message => {
      console.log(message)
      this.chartOptions.series = message;
      this.updateFromInput = true;
      this.chart.hideLoading();
    })
    const self = this;
    this.chartCallback = (chart) => {
      self.chart = chart;
    }
  }
  chart;
  updateFromInput = false;
  chartCallback;
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
