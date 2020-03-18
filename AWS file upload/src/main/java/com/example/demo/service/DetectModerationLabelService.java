package com.example.demo.service;

import com.amazonaws.services.rekognition.model.ModerationLabel;

import java.util.List;

public interface DetectModerationLabelService {

    List<ModerationLabel> getModerationLabels(byte[] bytes);

}
