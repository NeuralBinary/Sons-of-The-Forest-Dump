using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Shapes
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public class ImmediateModeShapeDrawer : MonoBehaviour
	{
		// Token: 0x06000A97 RID: 2711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public virtual void DrawShapes(Camera cam)
		{
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x2A39D10", Offset = "0x2A38310", VA = "0x182A39D10")]
		private void OnCameraPreRender(Camera cam)
		{
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x2A39DE0", Offset = "0x2A383E0", VA = "0x182A39DE0", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x2A39E70", Offset = "0x2A38470", VA = "0x182A39E70", Slot = "6")]
		public virtual void OnDisable()
		{
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x2A39F00", Offset = "0x2A38500", VA = "0x182A39F00")]
		private void DrawShapesSRP(ScriptableRenderContext ctx, Camera cam)
		{
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ImmediateModeShapeDrawer()
		{
		}

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("When enabled, shapes will only draw in cameras that can see the layer of this GameObject")]
		public bool useCullingMasks;
	}
}
