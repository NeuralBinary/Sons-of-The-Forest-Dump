using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x02000187 RID: 391
	[Token(Token = "0x2000187")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_object_placer.php")]
	public class ObjectPlacer : MonoBehaviour
	{
		// Token: 0x06000BE7 RID: 3047 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x655FC0", Offset = "0x6545C0", VA = "0x180655FC0")]
		private void Update()
		{
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x656140", Offset = "0x654740", VA = "0x180656140")]
		public void PlaceObject()
		{
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x656570", Offset = "0x654B70", VA = "0x180656570")]
		public IEnumerator RemoveObject()
		{
			return null;
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x656600", Offset = "0x654C00", VA = "0x180656600")]
		public ObjectPlacer()
		{
		}

		// Token: 0x040008C3 RID: 2243
		[Token(Token = "0x40008C3")]
		[FieldOffset(Offset = "0x20")]
		public GameObject go;

		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x40008C4")]
		[FieldOffset(Offset = "0x28")]
		public bool direct;

		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x40008C5")]
		[FieldOffset(Offset = "0x29")]
		public bool issueGUOs;
	}
}
