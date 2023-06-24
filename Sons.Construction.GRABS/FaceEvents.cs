using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200001F RID: 31
	[Token(Token = "0x200001F")]
	public static class FaceEvents
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2D92E10", Offset = "0x2D91410", VA = "0x182D92E10")]
		public static void RegisterFaceTargetedReceiver(IFaceTargetedReceiver receiver)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2D92F50", Offset = "0x2D91550", VA = "0x182D92F50")]
		public static void UnregisterFaceTargetedReceiver(IFaceTargetedReceiver receiver)
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2D92FD0", Offset = "0x2D915D0", VA = "0x182D92FD0")]
		public static void RegisterFaceCreatedReceiver(IFaceCreatedReceiver receiver)
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2D93120", Offset = "0x2D91720", VA = "0x182D93120")]
		public static void UnregisterFaceCreatedReceiver(IFaceCreatedReceiver receiver)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2D931A0", Offset = "0x2D917A0", VA = "0x182D931A0")]
		public static void RegisterFaceChangedReceiver(IFaceChangedReceiver receiver)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2D932F0", Offset = "0x2D918F0", VA = "0x182D932F0")]
		public static void UnregisterFaceChangedReceiver(IFaceChangedReceiver receiver)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2D93370", Offset = "0x2D91970", VA = "0x182D93370")]
		public static void RegisterDestroyingFaceReceiver(IDestroyingFaceReceiver receiver)
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2D934C0", Offset = "0x2D91AC0", VA = "0x182D934C0")]
		public static void UnregisterDestroyingFaceReceiver(IDestroyingFaceReceiver receiver)
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2D93540", Offset = "0x2D91B40", VA = "0x182D93540")]
		public static void FaceUntargeted(BlueprintFace prevFace)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2D936D0", Offset = "0x2D91CD0", VA = "0x182D936D0")]
		public static void FaceTargeted(BlueprintFace face)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2D93860", Offset = "0x2D91E60", VA = "0x182D93860")]
		public static void OnFaceCreated(BlueprintFace face)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2D939F0", Offset = "0x2D91FF0", VA = "0x182D939F0")]
		public static void OnFaceChanged(BlueprintFace face)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2D93B80", Offset = "0x2D92180", VA = "0x182D93B80")]
		public static void OnDestroyingFace(BlueprintFace face)
		{
		}

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<IFaceTargetedReceiver> FaceTargetedReceivers;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<IFaceCreatedReceiver> FaceCreatedReceivers;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<IFaceChangedReceiver> FaceChangedReceivers;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x18")]
		private static readonly List<IDestroyingFaceReceiver> DestroyingFaceReceivers;
	}
}
