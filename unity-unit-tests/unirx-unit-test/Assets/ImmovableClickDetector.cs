using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

// ���콺�� �������� �ʴ� ���¿��� Ŭ�� �ٿ��� ����
// �巡�� �̺�Ʈ�� Ŭ�� �̺�Ʈ�� ���ÿ� ���� ���� �� �ʿ���
public class ImmovableClickDetector : MonoBehaviour
{
	public void Start()
	{
		var downStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)).Select(_ => Input.mousePosition);
		var upStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonUp(0)).Select(_ => Input.mousePosition);

		downStream.Subscribe(_=> Debug.Log("���콺 Ŭ�� �ٿ� "));
		upStream.Subscribe( _ => Debug.Log( "���콺 Ŭ�� �� " ) );
		downStream.Zip(upStream, (down, up) => down == up).Subscribe( samePos => 
		{ 
			if(samePos)
				Debug.Log( "���콺 ��ġ ����" );
		} );
	}
}
