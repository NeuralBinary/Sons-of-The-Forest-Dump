using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Lodding.CullingGroups
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public class HLodMonoManager : SingletonBehaviour<HLodMonoManager>
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x30CC9B0", Offset = "0x30CAFB0", VA = "0x1830CC9B0")]
		private void OnEnable()
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x30CC9C0", Offset = "0x30CAFC0", VA = "0x1830CC9C0")]
		private void OnDisable()
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x30CCA80", Offset = "0x30CB080", VA = "0x1830CCA80")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x30CCB00", Offset = "0x30CB100", VA = "0x1830CCB00")]
		private void RefreshCameraAndTransform()
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x30CD090", Offset = "0x30CB690", VA = "0x1830CD090")]
		private void RefreshCullingGroup()
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x30CD560", Offset = "0x30CBB60", VA = "0x1830CD560")]
		private void OnCullingGroupStateChanged(CullingGroupEvent sphere)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x30CC570", Offset = "0x30CAB70", VA = "0x1830CC570")]
		public static void Unregister(HLodMono hLodMono)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x30CD640", Offset = "0x30CBC40", VA = "0x1830CD640")]
		private void UnregisterInternal(HLodMono hLodMono)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x30CD760", Offset = "0x30CBD60", VA = "0x1830CD760")]
		public static void Register(HLodMono hLodMono)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x30CD7D0", Offset = "0x30CBDD0", VA = "0x1830CD7D0")]
		private void RegisterInternal(HLodMono hLodMono)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x30CDA80", Offset = "0x30CC080", VA = "0x1830CDA80")]
		private static void AddHLod(ObjectBoundingSphere objectBoundingSphere)
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x30CDC20", Offset = "0x30CC220", VA = "0x1830CDC20")]
		private void AddHLodInternal(ObjectBoundingSphere objectBoundingSphere)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x30CDD70", Offset = "0x30CC370", VA = "0x1830CDD70")]
		private static void RemoveHLod(int index)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x30CDF40", Offset = "0x30CC540", VA = "0x1830CDF40")]
		private void RemoveHLodInternal(int index)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x30CE0D0", Offset = "0x30CC6D0", VA = "0x1830CE0D0")]
		public HLodMonoManager()
		{
		}

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float[] _distances;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x38")]
		private List<ObjectBoundingSphere> _registeredHLodMonos;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x40")]
		private CullingGroup _cullingGroup;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x48")]
		private readonly BoundingSphere[] _boundingSpheres;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x50")]
		private int _dirtyFrame;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x58")]
		private Transform _targetTransform;
	}
}
