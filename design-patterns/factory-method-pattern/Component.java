package FactorMethod;

abstract class Component 
{
	protected abstract String getCompName();
	public Component() 
	{
		System.out.println(this.getCompName() + " ����");
	}
}

class Button extends Component 
{
	@Override
	protected String getCompName() { return "��ư"; }
}

class Switch extends Component 
{
	@Override
	protected String getCompName() { return "����ġ"; }
}

class Dropdown extends Component 
{
	@Override
	protected String getCompName() { return "����ٿ�"; }
}