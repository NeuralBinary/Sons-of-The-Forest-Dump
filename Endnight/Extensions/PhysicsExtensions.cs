using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Extensions
{
	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	public static class PhysicsExtensions
	{
		// Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000402")]
		[Address(RVA = "0xAA5BA0", Offset = "0xAA41A0", VA = "0x180AA5BA0")]
		public static void SetLogSharedMeshChanges(bool value)
		{
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x6000403")]
		[Address(RVA = "0xAA5C00", Offset = "0xAA4200", VA = "0x180AA5C00")]
		public static bool PassesLayer(this Collision other, LayerMask layerMask)
		{
			return default(bool);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x6000404")]
		[Address(RVA = "0xAA5CC0", Offset = "0xAA42C0", VA = "0x180AA5CC0")]
		public static bool PassesTag(this Collision other, List<string> tagWhiteList)
		{
			return default(bool);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000405")]
		[Address(RVA = "0xAA5D40", Offset = "0xAA4340", VA = "0x180AA5D40")]
		public static void SetSharedMesh(this MeshCollider meshCollider, Mesh mesh, [Optional] bool? convex, [Optional] bool? isTrigger)
		{
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000406")]
		[Address(RVA = "0xAA60D0", Offset = "0xAA46D0", VA = "0x180AA60D0")]
		public static MeshCollider AddMeshCollider(this GameObject targetGameObject, bool assignMeshFilterMesh, [Optional] Mesh colliderMesh)
		{
			return null;
		}

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Color LogMeshNameColorSource;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _cachedLogMeshNameColorString;

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string LogMeshNameColorString;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Color LogPathColorSource;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string _cachedLogPathColorString;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static string LogPathColorString;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static bool _logSharedMeshChanges;
	}
}
