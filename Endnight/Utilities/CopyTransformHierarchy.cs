using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	public class CopyTransformHierarchy : MonoBehaviour
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xA6D1F0", Offset = "0xA6B7F0", VA = "0x180A6D1F0")]
		private void Collect()
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xA6D360", Offset = "0xA6B960", VA = "0x180A6D360")]
		private void Apply()
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xA6D3D0", Offset = "0xA6B9D0", VA = "0x180A6D3D0")]
		private static void Apply(CopyTransformHierarchy.CopyTransformHierarchyData data, Transform target)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CopyTransformHierarchy()
		{
		}

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x20")]
		private CopyTransformHierarchy.CopyTransformHierarchyData _data;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x28")]
		private List<CopyTransformHierarchy.CopyTransformHierarchyData> _flatData;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _source;

		// Token: 0x02000025 RID: 37
		[Token(Token = "0x2000025")]
		[Serializable]
		public class CopyTransformHierarchyData
		{
			// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xA6D7B0", Offset = "0xA6BDB0", VA = "0x180A6D7B0")]
			public CopyTransformHierarchyData(Transform source)
			{
			}

			// Token: 0x060000CC RID: 204 RVA: 0x00002490 File Offset: 0x00000690
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xA6DCA0", Offset = "0xA6C2A0", VA = "0x180A6DCA0")]
			public Vector3 GetLocalPosition()
			{
				return default(Vector3);
			}

			// Token: 0x060000CD RID: 205 RVA: 0x000024A8 File Offset: 0x000006A8
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xA6DCC0", Offset = "0xA6C2C0", VA = "0x180A6DCC0")]
			public Quaternion GetLocalRotation()
			{
				return default(Quaternion);
			}

			// Token: 0x060000CE RID: 206 RVA: 0x000024C0 File Offset: 0x000006C0
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x781540", Offset = "0x77FB40", VA = "0x180781540")]
			public Vector3 GetLocalScale()
			{
				return default(Vector3);
			}

			// Token: 0x060000CF RID: 207 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xA6DCD0", Offset = "0xA6C2D0", VA = "0x180A6DCD0")]
			public CopyTransformHierarchy.CopyTransformHierarchyData GetChild(string targetName)
			{
				return null;
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x000024D8 File Offset: 0x000006D8
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xA6DE70", Offset = "0xA6C470", VA = "0x180A6DE70")]
			private bool MatchesName(string targetName)
			{
				return default(bool);
			}

			// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xA6DEB0", Offset = "0xA6C4B0", VA = "0x180A6DEB0")]
			public void GetFlatData(ref List<CopyTransformHierarchy.CopyTransformHierarchyData> flatData)
			{
			}

			// Token: 0x04000087 RID: 135
			[Token(Token = "0x4000087")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _name;

			// Token: 0x04000088 RID: 136
			[Token(Token = "0x4000088")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Vector3 _localPosition;

			// Token: 0x04000089 RID: 137
			[Token(Token = "0x4000089")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private Quaternion _localRotation;

			// Token: 0x0400008A RID: 138
			[Token(Token = "0x400008A")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			private Vector3 _localScale;

			// Token: 0x0400008B RID: 139
			[Token(Token = "0x400008B")]
			[FieldOffset(Offset = "0x40")]
			private List<CopyTransformHierarchy.CopyTransformHierarchyData> _children;
		}
	}
}
