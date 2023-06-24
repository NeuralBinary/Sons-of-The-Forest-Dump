using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Physics
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public class DisabledRigidbodyHelper : MonoBehaviour
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x31026E0", Offset = "0x3100CE0", VA = "0x1831026E0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x3102920", Offset = "0x3100F20", VA = "0x183102920")]
		private void OnDisable()
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x3102F10", Offset = "0x3101510", VA = "0x183102F10")]
		private void OnEnable()
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0xAB5B60", Offset = "0xAB4160", VA = "0x180AB5B60")]
		public DisabledRigidbodyHelper()
		{
		}

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _autoFindColliders;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Collider> _colliders;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x38")]
		private DisabledRigidbodyHelper.RigidbodySettings _storedRigidbodySettings;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x40")]
		private List<DisabledRigidbodyHelper.ColliderSettings> _storedColliderSettingsList;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x48")]
		private bool _hasDisabled;

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x2000014")]
		[Serializable]
		public class ColliderSettings
		{
			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000071 RID: 113 RVA: 0x0000221A File Offset: 0x0000041A
			// (set) Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000C")]
			public Collider Collider
			{
				[Token(Token = "0x6000071")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000072")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000073 RID: 115 RVA: 0x000022C8 File Offset: 0x000004C8
			// (set) Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000D")]
			public bool IsTrigger
			{
				[Token(Token = "0x6000073")]
				[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000074")]
				[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000075 RID: 117 RVA: 0x000022E0 File Offset: 0x000004E0
			// (set) Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000E")]
			public bool Enabled
			{
				[Token(Token = "0x6000075")]
				[Address(RVA = "0x26000D0", Offset = "0x25FE6D0", VA = "0x1826000D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000076")]
				[Address(RVA = "0x26000E0", Offset = "0x25FE6E0", VA = "0x1826000E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x3103220", Offset = "0x3101820", VA = "0x183103220")]
			public void OnEnable()
			{
			}

			// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x3103390", Offset = "0x3101990", VA = "0x183103390")]
			public void OnDisable(Collider eachCollider)
			{
			}

			// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ColliderSettings()
			{
			}
		}

		// Token: 0x02000015 RID: 21
		[Token(Token = "0x2000015")]
		[Serializable]
		public class RigidbodySettings
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600007A RID: 122 RVA: 0x0000221A File Offset: 0x0000041A
			// (set) Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000F")]
			public Rigidbody RigidBody
			{
				[Token(Token = "0x600007A")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600007B")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600007C RID: 124 RVA: 0x000022F8 File Offset: 0x000004F8
			// (set) Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000010")]
			public bool IsKinematic
			{
				[Token(Token = "0x600007C")]
				[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600007D")]
				[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600007E RID: 126 RVA: 0x00002310 File Offset: 0x00000510
			// (set) Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000011")]
			public bool IsSleeping
			{
				[Token(Token = "0x600007E")]
				[Address(RVA = "0x26000D0", Offset = "0x25FE6D0", VA = "0x1826000D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600007F")]
				[Address(RVA = "0x26000E0", Offset = "0x25FE6E0", VA = "0x1826000E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x3103520", Offset = "0x3101B20", VA = "0x183103520")]
			public void OnEnable()
			{
			}

			// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x3103690", Offset = "0x3101C90", VA = "0x183103690")]
			public void OnDisable(Rigidbody rigidbody)
			{
			}

			// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public RigidbodySettings()
			{
			}
		}
	}
}
