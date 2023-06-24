using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Lodding.CullingGroups
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	[Serializable]
	public class ObjectBoundingSphere
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event Action<int, int> OnRefreshLod
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x30CE3E0", Offset = "0x30CC9E0", VA = "0x1830CE3E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x30CE550", Offset = "0x30CCB50", VA = "0x1830CE550")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x17000019")]
		public bool IsVisible
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x21FA640", Offset = "0x21F8C40", VA = "0x1821FA640")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x1700001A")]
		public int LodIndex
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x30CE6C0", Offset = "0x30CCCC0", VA = "0x1830CE6C0")]
		public void SetLodIndex(int index)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x30CE6F0", Offset = "0x30CCCF0", VA = "0x1830CE6F0")]
		private void RefreshLod(int prev, int current)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
		public float GetRadius()
		{
			return 0f;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x25729B0", Offset = "0x2570FB0", VA = "0x1825729B0")]
		public void SetVisible(bool visible)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x30CE710", Offset = "0x30CCD10", VA = "0x1830CE710")]
		public void SetLodAndVisible(int lodIndex, bool visible)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x26F9F30", Offset = "0x26F8530", VA = "0x1826F9F30")]
		public void SetRadius(float radius)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2040020", Offset = "0x203E620", VA = "0x182040020")]
		public void SetPosition(Vector3 position)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1766460", Offset = "0x1764A60", VA = "0x181766460")]
		public Vector3 GetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x30CE750", Offset = "0x30CCD50", VA = "0x1830CE750")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x30CE820", Offset = "0x30CCE20", VA = "0x1830CE820")]
		public ObjectBoundingSphere()
		{
		}

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector3 _position;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _radius;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x20")]
		private int _lodIndex;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x24")]
		private bool _visible;
	}
}
