using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Gui.Input;
using TMPro;
using UnityEngine;

namespace Sons.Gui.HintSystem
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	[AddComponentMenu("Sons/Gui/HintSystem/HintTextMesh")]
	public class HintTextMesh : MonoBehaviour
	{
		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x305F320", Offset = "0x305D920", VA = "0x18305F320")]
		private void Randomize()
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x305F400", Offset = "0x305DA00", VA = "0x18305F400")]
		private void OnEnable()
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x305F4F0", Offset = "0x305DAF0", VA = "0x18305F4F0")]
		private void OnDisable()
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x305F580", Offset = "0x305DB80", VA = "0x18305F580")]
		private void Update()
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x305F6D0", Offset = "0x305DCD0", VA = "0x18305F6D0")]
		private void ShowNextHint()
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x305F7D0", Offset = "0x305DDD0", VA = "0x18305F7D0")]
		private void Test()
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x305F7E0", Offset = "0x305DDE0", VA = "0x18305F7E0")]
		private void SetupHint(string hintTest)
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x3060170", Offset = "0x305E770", VA = "0x183060170")]
		private void SetupInputIcon(Token nextToken)
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x30606E0", Offset = "0x305ECE0", VA = "0x1830606E0")]
		private static string ConvertToActionId(Token nextToken)
		{
			return null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x3060760", Offset = "0x305ED60", VA = "0x183060760")]
		private static string StripBraces(Token nextToken)
		{
			return null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x3060790", Offset = "0x305ED90", VA = "0x183060790")]
		private void SetupTextObject(string substring)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x3060CB0", Offset = "0x305F2B0", VA = "0x183060CB0")]
		private bool GetNextTokenIndex(string hintTest, int startIndex, out int tokenStartIndex, out int tokenEndIndex)
		{
			return default(bool);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x3060D50", Offset = "0x305F350", VA = "0x183060D50")]
		public HintTextMesh()
		{
		}

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HintDatabase _sourceDatabase;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CopyText _copyText;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _hintDurationSeconds;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TMP_Text _textTemplate;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DynamicInputIcon _dynamicInputIconTemplate;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _testHint;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x50")]
		private int _textTemplateCount;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x54")]
		private int _iconTemplateCount;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x58")]
		private int _currentHintIndex;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		private const string HintIndexId = "HintIndex";

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x60")]
		private List<GameObject> _instanceTemplates;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x68")]
		private float _hintStartTime;
	}
}
