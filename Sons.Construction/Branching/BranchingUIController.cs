using System;
using System.Runtime.InteropServices;
using Construction;
using Il2CppDummyDll;
using Sons.Gui.Input;
using UnityEngine;

namespace Sons.Construction.Branching
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[AddComponentMenu("Sons/Construction/Branching/BranchingUIController")]
	public class BranchingUIController : MonoBehaviour
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2D5D270", Offset = "0x2D5B870", VA = "0x182D5D270")]
		private void Start()
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2D5D280", Offset = "0x2D5B880", VA = "0x182D5D280")]
		private bool TryFindPreviewManager()
		{
			return default(bool);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2D5D560", Offset = "0x2D5BB60", VA = "0x182D5D560")]
		public void ShowTransformationPreview(IBranchingAction action, StructureElement element, [Optional] TargetInfo targetInfo, bool showBranchingLabel = true)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2D5ED60", Offset = "0x2D5D360", VA = "0x182D5ED60")]
		public void HideTransformationPreview()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BranchingUIController()
		{
		}

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LinkUiElement _targetLabel;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PreviewManager _previewManager;
	}
}
