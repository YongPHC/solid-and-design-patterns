﻿using Masny.Patterns.Behavioral.ChainOfResponsibility;
using Masny.Patterns.Behavioral.Command;
using Masny.Patterns.Behavioral.Interpreter;
using Masny.Patterns.Behavioral.Iterator;
using Masny.Patterns.Behavioral.Mediator;
using Masny.Patterns.Behavioral.MementoPattern;
using Masny.Patterns.Behavioral.Observer;
using Masny.Patterns.Behavioral.State;
using Masny.Patterns.Behavioral.Strategy;
using Masny.Patterns.Behavioral.TemplateMethod;
using Masny.Patterns.Behavioral.Visitor;
using Masny.Patterns.Creational.AbstractFactory;
using Masny.Patterns.Creational.Builder;
using Masny.Patterns.Creational.Factory;
using Masny.Patterns.Creational.Prototype;
using Masny.Patterns.Creational.Singleton;
using Masny.Patterns.Structural.Adapter;
using Masny.Patterns.Structural.Bridge;
using Masny.Patterns.Structural.Composite;
using Masny.Patterns.Structural.Decorator;
using Masny.Patterns.Structural.Facade;
using Masny.Patterns.Structural.Flyweight;
using Masny.Patterns.Structural.Proxy;
using Masny.SOLID.DIP;
using Masny.SOLID.ISP;
using Masny.SOLID.LSP;
using Masny.SOLID.OCP;
using Masny.SOLID.SRP;
using System;

namespace Masny.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Display();
            app.Start();

            //var SRP = new SingleResponsibilityPrinciple();
            //SRP.Start();

            //var OCP = new OpenClosedPrinciple();
            //OCP.Start();

            //var LSP = new LiskovSubstitutionPrinciple();
            //LSP.Start();

            //var ISP = new InterfaceSegregationPrinciple();
            //ISP.Start();

            //var DIP = new DependencyInversionPrinciple();
            //DIP.Start();

            //var builder = new BuilderPattern();
            //builder.Start();

            //var decorator = new DecoratorPattern();
            //decorator.Start();

            //var singleton = new SingletonPattern();
            //singleton.Start();

            //var strategy = new StrategyPattern();
            //strategy.Start();

            //var facade = new FacadePattern();
            //facade.Start();

            //var observer = new ObserverPattern();
            //observer.Start();

            //var prototype = new PrototypePattern();
            //prototype.Start();

            //var factory = new FactoryPattern();
            //factory.Start();

            //var abstractFactory = new AbstractFactoryPattern();
            //abstractFactory.Start();

            //var adapterPattern = new AdapterPattern();
            //adapterPattern.Start();

            //var proxyPattern = new ProxyPattern();
            //proxyPattern.Start();

            //var bridgePattern = new BridgePattern();
            //bridgePattern.Start();

            //var compositePattern = new CompositePattern();
            //compositePattern.Start();

            //var templateMethodPattern = new TemplateMethodPattern();
            //templateMethodPattern.Start();

            //var statePattern = new StatePattern();
            //statePattern.Start();

            //var flyweightPattern = new FlyweightPattern();
            //flyweightPattern.Start();

            //var iteratorPattern = new IteratorPattern();
            //iteratorPattern.Start();

            //var mediatorPattern = new MediatorPattern();
            //mediatorPattern.Start();

            //var chainOfResponsibilityPattern = new ChainOfResponsibilityPattern();
            //chainOfResponsibilityPattern.Start();

            //var mementoPattern = new MementoPattern();
            //mementoPattern.Start();

            //var commandPattern = new CommandPattern();
            //commandPattern.Start();

            //var interpreterPattern = new InterpreterPattern();
            //interpreterPattern.Start();

            //var visitorPattern = new VisitorPattern();
            //visitorPattern.Start();

            Console.ReadLine();
        }
    }
}
