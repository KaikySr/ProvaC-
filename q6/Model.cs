
public abstract class Enemy : Entity
{
    public int Column { get; set; }
    public int Line { get; set; }

    public abstract void Move();
    public abstract void Build();
}

public class Rock : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(0, 0, 40, 40); // Corpo não deslocado do centro original com tamanho 40x40
    }

    public override void Move()
    {
        Line++; //Cai
    }
}

public class TwoRock : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(-60, 0, 40, 40); // Corpo deslocado do centro
        build(60, 0, 40, 40); // Outro corpo deslocado na outra direção
    }

    public override void Move()
    {
        Line += 3; //Cai mais rápido
        Column++; //Cai em diagonal
    }
}

public class Parado : Enemy
{
    public override void Build()
    {
        Column = 500;
        Line = 500;
        build(0, 0, 30, 30);
    }

    public override void Move(){}
}

public class Palito : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 300;
        build(0, 0, 10, 30);
    }

    public override void Move()
    {
        Line++;
    }
}

public class Plataforma : Enemy
{
    public override void Build()
    {
        Column = 0;
        Line = 0;
        build(-5, 0, 900, 40);
        build(1000, 0, 950, 40);
    }
    
    public override void Move()
    {
        Line++;
    }
}

public class Aleatorio : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = random(1000);
        build(0, 0, 40, 40); 
    }

    public override void Move()
    {
        Line += random(5); 
        Column += random(5); 
    }
}
public class Teleporta : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(0, 0, 40, 40); 
    }

    public override void Move()
    {
    
        Line += random(500); 
        
    }
}

public class Rapido : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(0, 0, 40, 40); 
    }

    public override void Move()
    {
        Line += 10; 
        
    }
}

public class Horizontal : Enemy
{
    public override void Build()
    {
        Column = random(1000);
        Line = 0;
        build(0, 0, 40, 40); 
    }

    public override void Move()
    {
        Line += 3; 
        Column += random(10);
        
    }
}
