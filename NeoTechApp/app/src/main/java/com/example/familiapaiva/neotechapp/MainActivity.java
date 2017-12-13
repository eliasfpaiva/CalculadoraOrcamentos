package com.example.familiapaiva.neotechapp;

import android.annotation.SuppressLint;
import android.content.Context;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.view.inputmethod.InputMethodManager;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    @SuppressLint("DefaultLocale")
    public void calcular(){
        try

        {
            InputMethodManager imm = (InputMethodManager)getSystemService(INPUT_METHOD_SERVICE);
            imm.hideSoftInputFromWindow(getCurrentFocus().getWindowToken(), 0);

            EditText orcamento   = (EditText) findViewById(R.id.campo_orcamento_inicial);
            EditText margemLucro = (EditText) findViewById(R.id.campo_margem_lucro);
            EditText taxaTributo = (EditText) findViewById(R.id.campo_taxa_tributaria);

            String sOrcamento   = orcamento  .getText().toString();
            String sMargemLucro = margemLucro.getText().toString();
            String sTaxaTributo = taxaTributo.getText().toString();

            double dOrcamento   = Double.parseDouble(sOrcamento);
            double dMargemLucro = Double.parseDouble(sMargemLucro);
            double dTaxaTributo = Double.parseDouble(sTaxaTributo);

            //Tributo não pode ter valor superior a 100%
            if (dTaxaTributo > 100) { throw new OverValueException(); }

            //O valor do lucro é dado por uma porcentagem do orçamento inicial
            double lucro = dOrcamento * (dMargemLucro / 100);

            //O valor final é pensado levando em conta que, descontando o tributo,
            //reste o valor da soma do orçamento inicial com o lucro desejando
            //dessa forma consideramos que o valor final é o que será considerado
            //para os cálculos de tributação.
            //O valor final é dado pela soma do Orçamento Inicial com o lucro e o tributo.
            //Com tudo isto em mente considero que o valor desejado para a soma de lucro
            //com orçamento inicial seja igual a 100% do valor final subtraído da taxa tributária,
            //a partir disso basta aplicar regra de 3 para se obter o valor final necessário
            //para garantir que o restante(valor descontando o tributo) seja o valor desejado para a
            //soma de Orçamento inicial com lucro desejado.

            double valorDesejado = dOrcamento + lucro;
            double valorFinal = (100 * valorDesejado) / (100 - dTaxaTributo);

            //O valor do tributo é dado pela porcentagem do orçamento final
            double valorTributo = valorFinal * (dTaxaTributo / 100);

            TextView campoValorLucro     = (TextView) findViewById(R.id.campo_valor_lucro);
            TextView campoValorTributo   = (TextView) findViewById(R.id.campo_valor_tributos);
            TextView campoOrcamentoFinal = (TextView) findViewById(R.id.campo_valor_final_orcamento);

            campoValorLucro    .setText(String.format("%.2f", lucro));
            campoValorTributo  .setText(String.format("%.2f", valorTributo));
            campoOrcamentoFinal.setText(String.format("%.2f", valorFinal));
        }
        catch (OverValueException ov)
        {
            Toast.makeText(this,"Taxa tributária nunca pode ser superior a 100%.", Toast.LENGTH_SHORT).show();
        }
        catch (Exception e)
        {
            Toast.makeText(this,"Todos os campos devem ser preenchidos corretamente", Toast.LENGTH_SHORT).show();
        }
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        findViewById(R.id.btn_calcular).setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {
        switch (view.getId()){
            case R.id.btn_calcular:
                calcular();
                break;
        }
    }

    // TODO: 13/12/2017 Implementar botões de limpar e de mais informações 
}
