using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cinematics
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public class RecordTransforms : MonoBehaviour
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2D58770", Offset = "0x2D56D70", VA = "0x182D58770")]
		public RecordTransforms()
		{
		}

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Transform> _transforms;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _outFolder;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x30")]
		private List<TransformSnapshots> _stores;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _minTimeStep;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[HideInInspector]
		private float _savedCaptureDeltaTime;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _stopTime;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x44")]
		private float _lastUpdate;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x48")]
		private float _firstUpdate;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool _worldPos;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x4D")]
		[SerializeField]
		private bool _worldRot;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x4E")]
		private bool _recordStarted;
	}
}
