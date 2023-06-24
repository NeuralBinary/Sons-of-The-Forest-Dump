using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public class DynamicInteractionPointDirectionVisual : MonoBehaviour, IInteractionPointEventReceiver
	{
		// Token: 0x06000190 RID: 400 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2D995B0", Offset = "0x2D97BB0", VA = "0x182D995B0")]
		private void Awake()
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2D99830", Offset = "0x2D97E30", VA = "0x182D99830")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2D998A0", Offset = "0x2D97EA0", VA = "0x182D998A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2D998E0", Offset = "0x2D97EE0", VA = "0x182D998E0", Slot = "4")]
		private void OnGrabbed(IAimRayProvider aimRayProvider)
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2D99990", Offset = "0x2D97F90", VA = "0x182D99990", Slot = "6")]
		private void StartedOperation(IAimRayProvider aimRayProvider)
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2D999A0", Offset = "0x2D97FA0", VA = "0x182D999A0", Slot = "7")]
		private void FinishedOperation(IAimRayProvider aimRayProvider)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2D999B0", Offset = "0x2D97FB0", VA = "0x182D999B0", Slot = "5")]
		private void OnUnGrabbed(IAimRayProvider aimRayProvider)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2D99A80", Offset = "0x2D98080", VA = "0x182D99A80")]
		private ExtrudeDir CalcExtrudeAxisFromAim()
		{
			return ExtrudeDir.Aligned;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2D99BC0", Offset = "0x2D981C0", VA = "0x182D99BC0")]
		private void SetExtrudeAxis(ExtrudeDir extrudeAxis)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DynamicInteractionPointDirectionVisual()
		{
		}

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Renderer _defaultIcon;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VisualFader _stretchForwardArrow;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VisualFader _extrudeOnSideArrow;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x38")]
		private InteractionPoint _targetIp;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x40")]
		private IAimRayProvider _aimRayProvider;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x48")]
		private ExtrudeDir _currentDir;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x49")]
		private bool _runningOperation;
	}
}
