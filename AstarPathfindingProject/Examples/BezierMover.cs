using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x02000172 RID: 370
	[Token(Token = "0x2000172")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_bezier_mover.php")]
	public class BezierMover : MonoBehaviour
	{
		// Token: 0x06000B86 RID: 2950 RVA: 0x00006E3C File Offset: 0x0000503C
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x64B7B0", Offset = "0x649DB0", VA = "0x18064B7B0")]
		private Vector3 Position(float t)
		{
			return default(Vector3);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x64BBC0", Offset = "0x64A1C0", VA = "0x18064BBC0")]
		private void Update()
		{
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x64C360", Offset = "0x64A960", VA = "0x18064C360")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x64C640", Offset = "0x64AC40", VA = "0x18064C640")]
		public BezierMover()
		{
		}

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[FieldOffset(Offset = "0x20")]
		public Transform[] points;

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0x28")]
		public float speed;

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x4000856")]
		[FieldOffset(Offset = "0x2C")]
		public float tiltAmount;

		// Token: 0x04000857 RID: 2135
		[Token(Token = "0x4000857")]
		[FieldOffset(Offset = "0x30")]
		private float time;
	}
}
