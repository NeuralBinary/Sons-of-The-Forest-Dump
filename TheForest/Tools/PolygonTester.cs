using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Tools
{
	// Token: 0x02000427 RID: 1063
	[Token(Token = "0x2000427")]
	public class PolygonTester : MonoBehaviour
	{
		// Token: 0x06001B73 RID: 7027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B73")]
		[Address(RVA = "0x2CE9BA0", Offset = "0x2CE8BA0", VA = "0x182CE9BA0")]
		private void Update()
		{
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B74")]
		[Address(RVA = "0x2CE9E60", Offset = "0x2CE8E60", VA = "0x182CE9E60")]
		public PolygonTester()
		{
		}

		// Token: 0x04001AAD RID: 6829
		[Token(Token = "0x4001AAD")]
		[FieldOffset(Offset = "0x20")]
		public List<Transform> _points;

		// Token: 0x04001AAE RID: 6830
		[Token(Token = "0x4001AAE")]
		[FieldOffset(Offset = "0x28")]
		public Transform _tester;

		// Token: 0x04001AAF RID: 6831
		[Token(Token = "0x4001AAF")]
		[FieldOffset(Offset = "0x30")]
		public bool _testerIsInPolygon;

		// Token: 0x04001AB0 RID: 6832
		[Token(Token = "0x4001AB0")]
		[FieldOffset(Offset = "0x31")]
		public bool _updateList;

		// Token: 0x04001AB1 RID: 6833
		[Token(Token = "0x4001AB1")]
		[FieldOffset(Offset = "0x38")]
		private List<Vector3> _points3d;
	}
}
