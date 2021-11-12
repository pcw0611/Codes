package Observer;

// ��ư�� �������� ���� ����� �ȴ�
// �׸��� ��ư�� ���� �� �������� �뺸�Ѵ�
public class Button 
{
	// Listener Interface�� �������� �ȴ�. Ŭ���� �� �״�� OnClick �̺�Ʈ�� ���� û�븦 �ǽ��Ѵ�
	public interface OnClickListener // Observer
	{
		void OnClick(Button button); // Update
	}
	
	private OnClickListener onClickListener;
	
	public void OnClick()
	{
		// �̺�Ʈ ó��
		if( null != onClickListener )
			onClickListener.OnClick( this );	// Update
	}
	public void SetOnClickListener( OnClickListener onClickListener )
	{
		this.onClickListener = onClickListener;
	}	
}
