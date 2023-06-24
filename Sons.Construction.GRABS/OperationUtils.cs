using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	internal static class OperationUtils
	{
		// Token: 0x0600022B RID: 555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2DAA280", Offset = "0x2DA8880", VA = "0x182DAA280")]
		internal static void DestroyFace(BlueprintFace face)
		{
		}

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x2000057")]
		internal static class IP
		{
			// Token: 0x0600022C RID: 556 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x2DAA990", Offset = "0x2DA8F90", VA = "0x182DAA990")]
			internal static void FadeInteractionPoints(Blueprint blueprint, InteractionPoint exceptIp, Fade mode)
			{
			}

			// Token: 0x0600022D RID: 557 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x2DAAAF0", Offset = "0x2DA90F0", VA = "0x182DAAAF0")]
			internal static void FadeInteractionPoints(BlueprintFace face, InteractionPoint exceptIp, Fade mode)
			{
			}

			// Token: 0x0600022E RID: 558 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x2DAAD10", Offset = "0x2DA9310", VA = "0x182DAAD10")]
			internal static void GenerateInteractionPoints(BlueprintFace face)
			{
			}
		}

		// Token: 0x02000058 RID: 88
		[Token(Token = "0x2000058")]
		internal static class Connexions
		{
			// Token: 0x0600022F RID: 559 RVA: 0x00002BF4 File Offset: 0x00000DF4
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x2DAB620", Offset = "0x2DA9C20", VA = "0x182DAB620")]
			internal static bool CheckFacesConnectedOnZAxis(BlueprintFace face, BlueprintFace connectedFace)
			{
				return default(bool);
			}

			// Token: 0x06000230 RID: 560 RVA: 0x00002C0C File Offset: 0x00000E0C
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x2DAB890", Offset = "0x2DA9E90", VA = "0x182DAB890")]
			internal static bool CheckFacesConnectedOnXAxis(BlueprintFace face, BlueprintFace connectedFace)
			{
				return default(bool);
			}

			// Token: 0x06000231 RID: 561 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x2DABAF0", Offset = "0x2DAA0F0", VA = "0x182DABAF0")]
			internal static void CopyConnexions(BlueprintFace fromFace, BlueprintFace toFace)
			{
			}

			// Token: 0x06000232 RID: 562 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x2DABCD0", Offset = "0x2DAA2D0", VA = "0x182DABCD0")]
			internal static void ToggleConnexions(BlueprintFace face, IReadOnlyList<BlueprintFace> faceList)
			{
			}

			// Token: 0x06000233 RID: 563 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x2DAC0B0", Offset = "0x2DAA6B0", VA = "0x182DAC0B0")]
			[CompilerGenerated]
			internal static void <ToggleConnexions>g__DrawCornersDebug|3_0(Vector3[] corners, float cornerRadius, float offset, Color color)
			{
			}

			// Token: 0x06000234 RID: 564 RVA: 0x00002C24 File Offset: 0x00000E24
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x2DAC160", Offset = "0x2DAA760", VA = "0x182DAC160")]
			[CompilerGenerated]
			internal static bool <ToggleConnexions>g__TryFindMatchingCorners|3_1(Vector3[] corners2, int targetCornerCount, ref OperationUtils.Connexions.<>c__DisplayClass3_0 A_2)
			{
				return default(bool);
			}

			// Token: 0x06000235 RID: 565 RVA: 0x0000213E File Offset: 0x0000033E
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x2DAC270", Offset = "0x2DAA870", VA = "0x182DAC270")]
			[CompilerGenerated]
			internal static Vector3[] <ToggleConnexions>g__CalcFaceCorners|3_2(BlueprintFace f)
			{
				return null;
			}
		}

		// Token: 0x0200005A RID: 90
		[Token(Token = "0x200005A")]
		internal static class Aim
		{
			// Token: 0x06000236 RID: 566 RVA: 0x00002C3C File Offset: 0x00000E3C
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x2DAC740", Offset = "0x2DAAD40", VA = "0x182DAC740")]
			private static Ray GetAimRay(Transform transform)
			{
				return default(Ray);
			}

			// Token: 0x06000237 RID: 567 RVA: 0x00002C54 File Offset: 0x00000E54
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x2DAC890", Offset = "0x2DAAE90", VA = "0x182DAC890")]
			internal static float CalcPlaceDistance(InteractionPoint ip, Transform aimTransform, float snapDistance)
			{
				return 0f;
			}

			// Token: 0x06000238 RID: 568 RVA: 0x00002C6C File Offset: 0x00000E6C
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x2DACBD0", Offset = "0x2DAB1D0", VA = "0x182DACBD0")]
			private static float GetAimDistance(Transform aimTransform, float maxDistance)
			{
				return 0f;
			}

			// Token: 0x06000239 RID: 569 RVA: 0x00002C84 File Offset: 0x00000E84
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x2DACF80", Offset = "0x2DAB580", VA = "0x182DACF80")]
			internal static Vector3 GetAimPos(Transform aimTransform)
			{
				return default(Vector3);
			}

			// Token: 0x0600023A RID: 570 RVA: 0x00002C9C File Offset: 0x00000E9C
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x2DAD0A0", Offset = "0x2DAB6A0", VA = "0x182DAD0A0")]
			internal static Vector3 GetFlattenedAimPos(Transform aimTransform, float maxDistance = 4f)
			{
				return default(Vector3);
			}

			// Token: 0x0600023B RID: 571 RVA: 0x00002CB4 File Offset: 0x00000EB4
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x2DAD270", Offset = "0x2DAB870", VA = "0x182DAD270")]
			internal static Vector3 CalcOnIpForwardFacePosFromAim(Transform aimTransform, Vector3 faceOriginalPos, Transform ipTransform, float maxDistance = 4f)
			{
				return default(Vector3);
			}

			// Token: 0x0600023C RID: 572 RVA: 0x00002CCC File Offset: 0x00000ECC
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x2DAD570", Offset = "0x2DABB70", VA = "0x182DAD570")]
			internal static Vector3 GetProjectedFaceAttachPoint(BlueprintFace projectingFace, BlueprintFace to, bool connectedOnZAxis)
			{
				return default(Vector3);
			}

			// Token: 0x0600023D RID: 573 RVA: 0x00002CE4 File Offset: 0x00000EE4
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x2DAD870", Offset = "0x2DABE70", VA = "0x182DAD870")]
			internal static Vector3 GetFaceClosestExtremityPoint(Vector3 targetPos, BlueprintFace onFace, bool connectedOnZAxis, bool invert)
			{
				return default(Vector3);
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00002CFC File Offset: 0x00000EFC
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x2DADA40", Offset = "0x2DAC040", VA = "0x182DADA40")]
			internal static Vector3 SnapToGrid(Vector3 onFaceForwardAxisPos, Vector3 startPos, IArchetype archetype, bool canSnapToStartPos)
			{
				return default(Vector3);
			}

			// Token: 0x0600023F RID: 575 RVA: 0x00002D14 File Offset: 0x00000F14
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x2DADD80", Offset = "0x2DAC380", VA = "0x182DADD80")]
			[CompilerGenerated]
			internal static float <CalcOnIpForwardFacePosFromAim>g__CalcAimDistanceToMoveAxisPlane|6_0(Transform ipTr, Transform aimTransform)
			{
				return 0f;
			}

			// Token: 0x040000FF RID: 255
			[Token(Token = "0x40000FF")]
			private const float MaxPlaceDistance = 4f;
		}
	}
}
