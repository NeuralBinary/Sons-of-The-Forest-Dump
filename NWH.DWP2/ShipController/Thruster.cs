using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace NWH.DWP2.ShipController
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[Serializable]
	public class Thruster
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x1700005C")]
		public Vector3 WorldPosition
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x2718250", Offset = "0x2716850", VA = "0x182718250")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x1700005D")]
		public float Input
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x2718350", Offset = "0x2716950", VA = "0x182718350")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
		public void Initialize(AdvancedShipController sc)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x27183B0", Offset = "0x27169B0", VA = "0x1827183B0", Slot = "4")]
		public virtual void Update()
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2718880", Offset = "0x2716E80", VA = "0x182718880")]
		public Thruster()
		{
		}

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x10")]
		public Thruster.ThrusterPosition thrusterPosition;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Name of the thruster - can be any string.")]
		public string name;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Relative force application position.")]
		public Vector3 position;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Max thrust in [N].")]
		public float maxThrust;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Time needed to reach maxThrust.")]
		public float spinUpSpeed;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Optional. Transform representing a propeller. Visual only.")]
		public Transform propellerTransform;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Rotation direction of the propeller. Visual only.")]
		[FormerlySerializedAs("rotationDirection")]
		public Thruster.RotationDirection propellerRotationDirection;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Rotation speed of the propeller if assigned. Visual only.")]
		public float propellerRotationSpeed;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x48")]
		private AdvancedShipController sc;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x50")]
		private float thrust;

		// Token: 0x0200002D RID: 45
		[Token(Token = "0x200002D")]
		public enum RotationDirection
		{
			// Token: 0x04000180 RID: 384
			[Token(Token = "0x4000180")]
			Left,
			// Token: 0x04000181 RID: 385
			[Token(Token = "0x4000181")]
			Right
		}

		// Token: 0x0200002E RID: 46
		[Token(Token = "0x200002E")]
		public enum ThrusterPosition
		{
			// Token: 0x04000183 RID: 387
			[Token(Token = "0x4000183")]
			BowThruster,
			// Token: 0x04000184 RID: 388
			[Token(Token = "0x4000184")]
			SternThruster
		}
	}
}
