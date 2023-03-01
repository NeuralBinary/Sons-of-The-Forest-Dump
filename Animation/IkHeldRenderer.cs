using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000893 RID: 2195
	[Token(Token = "0x2000893")]
	public class IkHeldRenderer : MonoBehaviour, IIkHeldRenderer, IMonoBehaviour
	{
		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06003B32 RID: 15154 RVA: 0x000113B8 File Offset: 0x0000F5B8
		[Token(Token = "0x1700073A")]
		public IkLimbs Limb
		{
			[Token(Token = "0x6003B32")]
			[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330", Slot = "4")]
			get
			{
				return IkLimbs.RightHand;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06003B33 RID: 15155 RVA: 0x000113D0 File Offset: 0x0000F5D0
		// (set) Token: 0x06003B34 RID: 15156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700073B")]
		public Vector3 InitialLocalPosition
		{
			[Token(Token = "0x6003B33")]
			[Address(RVA = "0x6C5520", Offset = "0x6C4520", VA = "0x1806C5520", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003B34")]
			[Address(RVA = "0x6C5580", Offset = "0x6C4580", VA = "0x1806C5580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06003B35 RID: 15157 RVA: 0x000113E8 File Offset: 0x0000F5E8
		// (set) Token: 0x06003B36 RID: 15158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700073C")]
		public Quaternion InitialLocalRotation
		{
			[Token(Token = "0x6003B35")]
			[Address(RVA = "0x12E73D0", Offset = "0x12E63D0", VA = "0x1812E73D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6003B36")]
			[Address(RVA = "0x12E73F0", Offset = "0x12E63F0", VA = "0x1812E73F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06003B37 RID: 15159 RVA: 0x00011400 File Offset: 0x0000F600
		// (set) Token: 0x06003B38 RID: 15160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700073D")]
		public Vector3 InitialLocalScale
		{
			[Token(Token = "0x6003B37")]
			[Address(RVA = "0x5A23B0", Offset = "0x5A13B0", VA = "0x1805A23B0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6003B38")]
			[Address(RVA = "0x5A28D0", Offset = "0x5A18D0", VA = "0x1805A28D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B39")]
		[Address(RVA = "0x2EFAAF0", Offset = "0x2EF9AF0", VA = "0x182EFAAF0")]
		private void Awake()
		{
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3A")]
		[Address(RVA = "0x2EFAEA0", Offset = "0x2EF9EA0", VA = "0x182EFAEA0")]
		private void Start()
		{
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3B")]
		[Address(RVA = "0x2EFADC0", Offset = "0x2EF9DC0", VA = "0x182EFADC0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3C")]
		[Address(RVA = "0x2EFABF0", Offset = "0x2EF9BF0", VA = "0x182EFABF0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3D")]
		[Address(RVA = "0x2EFAB60", Offset = "0x2EF9B60", VA = "0x182EFAB60")]
		private void Init()
		{
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3E")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public IkHeldRenderer()
		{
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B3F")]
		[Address(RVA = "0x288E5E0", Offset = "0x288D5E0", VA = "0x18288E5E0", Slot = "8")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B40")]
		[Address(RVA = "0x5E9620", Offset = "0x5E8620", VA = "0x1805E9620", Slot = "9")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x00011418 File Offset: 0x0000F618
		[Token(Token = "0x6003B41")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04003F99 RID: 16281
		[Token(Token = "0x4003F99")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private IkLimbs _limb;

		// Token: 0x04003F9A RID: 16282
		[Token(Token = "0x4003F9A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private IkTargetsController _controller;

		// Token: 0x04003F9B RID: 16283
		[Token(Token = "0x4003F9B")]
		[FieldOffset(Offset = "0x30")]
		private bool _isInitialized;
	}
}
