package com.example.familiapaiva.neotechapp;

/**
 * Created by Familia Paiva on 12/12/2017.
 */

public class UnderZeroException extends Exception {
    @Override
    public String toString() {
        return "Valor menor que zero detectado";
    }
}
