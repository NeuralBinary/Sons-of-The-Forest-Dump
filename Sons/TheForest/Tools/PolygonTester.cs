using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Tools
{
	// Token: 0x02000419 RID: 1049
	[Token(Token = "0x2000419")]
	public class PolygonTester : MonoBehaviour
	{
		// Token: 0x06001BB1 RID: 7089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB1")]
		[Address(RVA = "0x32BB8E0", Offset = "0x32B9EE0", VA = "0x1832BB8E0")]
		private void Update()
		{
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB2")]
		[Address(RVA = "0x32BBD90", Offset = "0x32BA390", VA = "0x1832BBD90")]
		public PolygonTester()
		{
		}

		// Token: 0x04001AD1 RID: 6865
		[Token(Token = "0x4001AD1")]
		[FieldOffset(Offset = "0x20")]
		public List<Transform> _points;

		// Token: 0x04001AD2 RID: 6866
		[Token(Token = "0x4001AD2")]
		[FieldOffset(Offset = "0x28")]
		public Transform _tester;

		// Token: 0x04001AD3 RID: 6867
		[Token(Token = "0x4001AD3")]
		[FieldOffset(Offset = "0x30")]
		public bool _testerIsInPolygon;

		// Token: 0x04001AD4 RID: 6868
		[Token(Token = "0x4001AD4")]
		[FieldOffset(Offset = "0x31")]
		public bool _updateList;

		// Token: 0x04001AD5 RID: 6869
		[Token(Token = "0x4001AD5")]
		[FieldOffset(Offset = "0x38")]
		private List<Vector3> _points3d;
	}
}
