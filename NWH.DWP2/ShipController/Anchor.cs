using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.ShipController
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public class Anchor : MonoBehaviour
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000032")]
		public Rigidbody ParentRigidbody
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x620F20", Offset = "0x61F520", VA = "0x180620F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000025F4 File Offset: 0x000007F4
		[Token(Token = "0x17000033")]
		public Vector3 AnchorPoint
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x270DDD0", Offset = "0x270C3D0", VA = "0x18270DDD0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000260C File Offset: 0x0000080C
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000034")]
		public Vector3 AnchorPosition
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x23BB6A0", Offset = "0x23B9CA0", VA = "0x1823BB6A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x270DED0", Offset = "0x270C4D0", VA = "0x18270DED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002624 File Offset: 0x00000824
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000035")]
		public bool Dropped
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x270DEE0", Offset = "0x270C4E0", VA = "0x18270DEE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x270DEF0", Offset = "0x270C4F0", VA = "0x18270DEF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000263C File Offset: 0x0000083C
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000036")]
		public bool IsDragging
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x7283F0", Offset = "0x7269F0", VA = "0x1807283F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x270DF00", Offset = "0x270C500", VA = "0x18270DF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x270DF10", Offset = "0x270C510", VA = "0x18270DF10")]
		private void Start()
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x270E0D0", Offset = "0x270C6D0", VA = "0x18270E0D0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x270E3B0", Offset = "0x270C9B0", VA = "0x18270E3B0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x270E560", Offset = "0x270CB60", VA = "0x18270E560")]
		public void Drop()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x270E5A0", Offset = "0x270CBA0", VA = "0x18270E5A0")]
		public void Weigh()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x270E5B0", Offset = "0x270CBB0", VA = "0x18270E5B0")]
		public Anchor()
		{
		}

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Should the anchor be dropped at start?")]
		public bool dropOnStart;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("Coefficient by which the force will be multiplied when the object starts pulling on the anchor.")]
		public float forceCoefficient;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Radius around anchor in which the chain/rope is slack and in which no force will be applied.")]
		public float zeroForceRadius;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Maximum force that can be applied to anchor before it starts to drag.")]
		public float dragForce;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Point in coordinates local to the object this script is attached to.")]
		public Vector3 localAnchorPoint;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _force;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 _distance;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 _prevDistance;
	}
}
