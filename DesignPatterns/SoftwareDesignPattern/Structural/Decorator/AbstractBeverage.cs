﻿namespace DesignPatterns.SoftwareDesignPattern.Structural.Decorator {
  public abstract class AbstractBeverage {
    public abstract int GetPrice();

    public override string ToString() => GetPrice().ToString();
  }
}
