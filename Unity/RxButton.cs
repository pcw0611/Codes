using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

public class RxButton : MonoBehaviour
{
	[SerializeField] private Button		button1;
	[SerializeField] private Button     button2;
	[SerializeField] private Text		text;

    // Start is called before the first frame update
    void Start()
    { 
		// * Stream Operators Examples

		// Buffer
		button1
			.OnClickAsObservable()
			.Buffer( 3 )
			.SubscribeToText( text, _ => "clicked" );
		//= Skip
		//button1
		//	.OnClickAsObservable()
		//	.Skip( 2 )
		//	.SubscribeToText( text, _ => "clicked" );

		// Zip
		// First + Repeat�� 1ȸ ������ ������ ��Ʈ���� �ٽ� ����
		button1.OnClickAsObservable()
			.Zip( button2.OnClickAsObservable(), ( b1, b2 ) => "Clicked" )
			.First()
			.Repeat()
			.SubscribeToText( text, x => text.text + x + "\n" );

		// Filter (����)
		// Map (�޼��� ����)
		// SelectMany (���ο� ��Ʈ���� �����ϰ� �� ��Ʈ���� �帣�� �޼����� ������ ��Ʈ���� �޽����� ���, FlatMap)
		// Throttle (����Ʋ, debounce) ������ �� ������ �޼����� ó�� (Ű�� ��û ������ ������ Ű�� ó����) ������ ���� Ŭ�� �Ǽ����� �̿��� ����
		// Throttle ���ʿ� �޼����� �ö����� ���� �ð� ���� (���� �޼����� ��������)
		// Delay (�޼��� ���� ����)
		// DistinctUntilChanged (���� ����ɶ��� ����) true / false ���� ó��
		// SkilUntil (������ ��Ʈ���� �޼����� �ö����� �޼����� ��ŵ��
		// TakeUntil (�޼��� �������� �ٸ����� �޼��� ���� ��Ʈ�� ������)
		// Repeat
		// SkipUntil + TakUntil + Repeat 
		// �̺�Ʈ A�� �ö����� �̺�Ʈ B�� �ö����� ó���� �� ��� ex) �巡�׷� ������Ʈ ȸ��

		// ���� ��뿹
		// 1. ���� Ŭ�� ����
		// 2. ���� ��ȭ ����
		// 3. ���� ��ȭ ���ٵ��
		// 4. WWW�� ����ϱ� ���� �ϱ�
		// 5. ���� ���̺귯���� ��Ʈ������ ��ȯ
	}
}