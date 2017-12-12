package com.example.familiapaiva.neotechapp;

/**
 * Created by Familia Paiva on 12/12/2017.
 */

public class OverValueException extends Exception {
    @Override
    public String toString() {
        return "Valor acima do permitido";
    }
}
