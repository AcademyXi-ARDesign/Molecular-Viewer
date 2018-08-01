using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModelMaster : MonoBehaviour {

	public ModelPiece[] ModelPieces;
	public string DefaultTitle;
	public TextMeshProUGUI TitleText;
	public TextMeshProUGUI DescriptionText;


	public void SetFocusPiece(int Target) {
		if(Target < 0 || Target >= ModelPieces.Length) {
			Debug.LogError("Out of bounds! :c");
			return;
		}

		for(int i = 0; i < ModelPieces.Length; i++) {
			if(i == Target) {
				ActivatePiece(i);
			} else {
				DeactivatePiece(i);
			}
		}
	}

	private void ActivatePiece(int Piece) {
		ModelPieces[Piece].gameObject.SetActive(true);
		TitleText.text = ModelPieces[Piece].TitleText;
		DescriptionText.text = ModelPieces[Piece].DescriptionText;
	}

	private void DeactivatePiece(int Piece) {
		ModelPieces[Piece].gameObject.SetActive(false);
	}

	public void ReturnToMainmodel() {
		for(int i = 0; i < ModelPieces.Length; i++) {
			ActivatePiece(i);
		}

		TitleText.text = DefaultTitle;
		DescriptionText.text = "";
	}

}