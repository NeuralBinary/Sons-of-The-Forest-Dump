using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Examples
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_mecanim_bridge.php")]
	public class MecanimBridge : VersionedMonoBehaviour
	{
		// Token: 0x06000BBD RID: 3005 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x64FA20", Offset = "0x64E020", VA = "0x18064FA20", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x64FD20", Offset = "0x64E320", VA = "0x18064FD20")]
		private void Update()
		{
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00006E9C File Offset: 0x0000509C
		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x64FDA0", Offset = "0x64E3A0", VA = "0x18064FDA0")]
		private Vector3 CalculateBlendPoint()
		{
			return default(Vector3);
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x650460", Offset = "0x64EA60", VA = "0x180650460")]
		private void OnAnimatorMove()
		{
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00006EB4 File Offset: 0x000050B4
		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x651130", Offset = "0x64F730", VA = "0x180651130")]
		private static Vector3 RotatePointAround(Vector3 point, Vector3 around, Quaternion rotation)
		{
			return default(Vector3);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00006ECC File Offset: 0x000050CC
		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x651220", Offset = "0x64F820", VA = "0x180651220", Slot = "10")]
		protected virtual Quaternion RotateTowards(Vector3 direction, float maxDegrees)
		{
			return default(Quaternion);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x651480", Offset = "0x64FA80", VA = "0x180651480")]
		public MecanimBridge()
		{
		}

		// Token: 0x04000884 RID: 2180
		[Token(Token = "0x4000884")]
		[FieldOffset(Offset = "0x28")]
		public float velocitySmoothing;

		// Token: 0x04000885 RID: 2181
		[Token(Token = "0x4000885")]
		[FieldOffset(Offset = "0x30")]
		private IAstarAI ai;

		// Token: 0x04000886 RID: 2182
		[Token(Token = "0x4000886")]
		[FieldOffset(Offset = "0x38")]
		private Animator anim;

		// Token: 0x04000887 RID: 2183
		[Token(Token = "0x4000887")]
		[FieldOffset(Offset = "0x40")]
		private Transform tr;

		// Token: 0x04000888 RID: 2184
		[Token(Token = "0x4000888")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 smoothedVelocity;

		// Token: 0x04000889 RID: 2185
		[Token(Token = "0x4000889")]
		[FieldOffset(Offset = "0x58")]
		private Vector3[] prevFootPos;

		// Token: 0x0400088A RID: 2186
		[Token(Token = "0x400088A")]
		[FieldOffset(Offset = "0x60")]
		private Transform[] footTransforms;
	}
}
