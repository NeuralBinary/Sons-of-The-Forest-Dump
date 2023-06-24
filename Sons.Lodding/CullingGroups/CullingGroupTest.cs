using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Lodding.CullingGroups
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public class CullingGroupTest : MonoBehaviour
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x17000018")]
		private bool IsPlaying
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x30CAEA0", Offset = "0x30C94A0", VA = "0x1830CAEA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x30CAF20", Offset = "0x30C9520", VA = "0x1830CAF20")]
		private void AutoFindObjectBoundingSpheres()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x30CB070", Offset = "0x30C9670", VA = "0x1830CB070")]
		private void OnEnable()
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x30CB1F0", Offset = "0x30C97F0", VA = "0x1830CB1F0")]
		private void RefreshDistances()
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x30CB310", Offset = "0x30C9910", VA = "0x1830CB310")]
		private void OnDisable()
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x30CB3D0", Offset = "0x30C99D0", VA = "0x1830CB3D0")]
		private void SetupCullingGroups()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x30CBDB0", Offset = "0x30CA3B0", VA = "0x1830CBDB0")]
		private void OnCullingGroupStateChanged(CullingGroupEvent sphere)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x30CBE60", Offset = "0x30CA460", VA = "0x1830CBE60")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x30CBEF0", Offset = "0x30CA4F0", VA = "0x1830CBEF0")]
		private void RuntimeGizmos()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void EditorGizmos()
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x30CC250", Offset = "0x30CA850", VA = "0x1830CC250")]
		public CullingGroupTest()
		{
		}

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _sourcePosition;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float[] _distanceBandDefs;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[FormerlySerializedAs("_boundingSpheresDefs")]
		private List<ObjectBoundingSphereMono> _objectBoundingSpheres;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int _virtualBoundingSphereCount;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[FormerlySerializedAs("_boundingSphereColorStart")]
		private Color _distanceBandsColorStart;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[FormerlySerializedAs("_boundingSphereColorEnd")]
		private Color _distanceBandsColorEnd;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x68")]
		private int[] _distanceBands;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x70")]
		private bool[] _visibility;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x78")]
		private BoundingSphere[] _boundingSpheres;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x80")]
		private ObjectBoundingSphere[] _cachedObjectBoundingSpheres;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x88")]
		private CullingGroup _cullingGroup;
	}
}
