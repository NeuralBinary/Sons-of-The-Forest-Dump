using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding;
using UnityEngine;

namespace Sons.Ai
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[AddComponentMenu("Sons/Ai/NavMeshUpdater")]
	public class NavMeshUpdater : MonoBehaviour
	{
		// Token: 0x06000073 RID: 115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2A96FC0", Offset = "0x2A955C0", VA = "0x182A96FC0")]
		private void Update()
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2A970B0", Offset = "0x2A956B0", VA = "0x182A970B0")]
		private bool CanUpdate()
		{
			return default(bool);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2A97260", Offset = "0x2A95860", VA = "0x182A97260")]
		private void DoGraphUpdate()
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2A97660", Offset = "0x2A95C60", VA = "0x182A97660")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2A97870", Offset = "0x2A95E70", VA = "0x182A97870")]
		public NavMeshUpdater()
		{
		}

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Bounds _bounds;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GraphMask _navGraphMask;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _updatePhysics;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x3D")]
		[SerializeField]
		private bool _modifyTag;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int _setTag;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x48")]
		private Queue<GraphUpdateObject> _pendingGraphUpdates;
	}
}
