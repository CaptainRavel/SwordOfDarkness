using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerSaveScript
{
    public int level;
    public int siła;
    public int zręcznosc;
    public int wytrzymalosc;
    public int refleks;
    public int grada;
    public int kontratak;
    public int currentHP;
    public int currentKon;
    public int maxHP;
    public int maxKon;
    public int obrazeniaMin;
    public int obrazeniaMax;
    public int blevel;
    public int bsiła;
    public int bzręcznosc;
    public int bwytrzymalosc;
    public int brefleks;
    public int bgrada;
    public int bkontratak;
    public int bcurrentHP;
    public int bcurrentKon;
    public int bobrazeniaMin;
    public int bobrazeniaMax;
    public int pImageNumber;
    public string pName;
    public int endbattleHP;
    public int endBattleKon;


    public PlayerSaveScript (Character player1)
    {
        bsiła = (int)Character.bsila;
        bzręcznosc = (int)Character.bzrecznosc;
        bwytrzymalosc = (int)Character.bwytrzymalosc;
        brefleks = (int)Character.brefleks;
        bgrada = (int)Character.bgardapercent;
        bkontratak = (int)Character.bkontrapercent;
        bcurrentHP = (int)Character.bcurrentHealth;
        bcurrentKon = (int)Character.bcurrentKon;
        bobrazeniaMin = (int)Character.bobrmin;
        bobrazeniaMax = (int)Character.bobrmax;
        blevel = (int)Character.blevel;
        siła = Character.sila;
        zręcznosc = Character.zrecznosc;
        wytrzymalosc = Character.wytrzymalosc;
        refleks = Character.refleks;
        grada = Character.gardapercent;
        kontratak = Character.kontrapercent;
        obrazeniaMin = Character.obrmin;
        obrazeniaMax = Character.obrmax;
        level = Character.blevel;
        currentHP = (int)Character.currentHealth;
        maxHP = (int)Character.maxHealth;
        currentKon = (int)Character.currentKon;
        maxKon = (int)Character.maxKon;
    }

    public PlayerSaveScript (HeroGenerationUIScript player2)
    {
        pImageNumber = HeroGenerationUIScript.imgnum;
        pName = HeroGenerationUIScript.hName;
    }

    public PlayerSaveScript(PlayerBattle player4)
    {
        endbattleHP = PlayerBattle.endbattlehealth;
        endBattleKon = PlayerBattle.endbattlekon;
    }
}
